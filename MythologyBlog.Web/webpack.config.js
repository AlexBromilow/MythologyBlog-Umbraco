const path = require('path');

module.exports = {
    entry: './wwwroot/Sitefiles/src/js/index.ts',
    module: {
        rules: [
            {
                test: /\.tsx?$/,
                use: 'ts-loader',
                exclude: /node_modules/,
            },
        ],
    },
    resolve: {
        extensions: ['.tsx', '.ts', '.js'],
    },
    output: {
        filename: 'main.js',
        path: path.resolve(__dirname, './wwwroot/Sitefiles/dist'),
    },
};