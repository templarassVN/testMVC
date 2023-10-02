const path = require('path');
module.exports = {
    entry: './wwwroot/js/import.js',
    output: {
        path: path.join(__dirname, '/wwwroot/js/dist'),
        filename: 'bundle.js',
    },
}