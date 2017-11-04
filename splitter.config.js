var fableUtils = require('fable-utils');
var path = require('path');

function find(filePath) {
  return path.resolve(__dirname, filePath);
}

const babelOpts = fableUtils.resolveBabelOptions({
  presets: [
    [
      'env', {
        'targets': {
          'node': 'current'
        }
      }
    ]
  ],
  plugins: ['transform-runtime']
});

const fableOpts = {
  babel: babelOpts
};

module.exports = {
  entry: find("./Sample/Sample.fsproj"),
  outDir: find("./dist/"),
  babel: babelOpts,
  fable: fableOpts
};
