export default {
  input: 'dist-temp/App.js',
  output: {
    file: 'dist/App.js',
    format: 'cjs'
  },
  external: [
    'left-pad'
  ]
}
