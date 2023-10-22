const path = require('path');
module.exports = {
    entry: {
        import : './wwwroot/js/import.js',
        learning: './wwwroot/js/Learning.js'
    },
    output: {
        path: path.join(__dirname, '/wwwroot/js/dist'),
        filename: '[name].bundle.js'
    },
}