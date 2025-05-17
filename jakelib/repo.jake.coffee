wtask = require('./tasks').wtask

namespace 'repo', ->
  desc 'Updates all sub modules in the repo'
  wtask 'update-submodules', { async: true }, ->
    args = [
      'git submodule update'
      '--init'
      '--recursive'
    ].join(' ')

    WellFired.info "Running git submodule update: #{args}"

    exec = require('child_process').exec
    exec args, (err, stdout, stderr) ->
      if err
        WellFired.error "Error: #{stderr}"
      else
        WellFired.info stdout
        complete()
        