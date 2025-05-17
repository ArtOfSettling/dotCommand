fs = require 'fs'
path = require 'path'

require('coffeescript/register')
require('string-format')
require('./config')

# Auto-load every .coffee task in jakelib
taskFiles = fs.readdirSync('./jakelib').filter((f) -> f.endsWith('.coffee'))

for file in taskFiles
    require(path.resolve('./jakelib', file))

jake.addListener 'start', ->
    jake.logger.log('\n{0} jake file starting ...'.format(config.name))

jake.addListener 'complete', ->
    jake.logger.log('{0} Done.\n'.format(config.name))
    