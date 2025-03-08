const path = require("path");
module.exports = {
    entry: "./src/index.tsx",
    devtool: 'inline-source-map',
    module: {
        rules: [
            {
                test: /.(js|jsx|ts|tsx)$/,
                exclude: [/node_modules/, /.config.mjs$/],
                use: [
                    {
                        loader: "babel-loader",
                        options: {
                            presets: ["@babel/preset-env", "@babel/preset-react"],
                        }
                    },
                    { loader: "ts-loader" }
                ]
            },
        ],
    },
    resolve: {
        extensions: ['.tsx', '.ts', '.jsx', '.js'],
        alias: {
            '@Widgets/*': path.resolve(__dirname, 'src/Components/Widgets/*'),
            '@UI/*': path.resolve(__dirname, 'src/Components/UI/*'),
            '@Lib/*': path.resolve(__dirname, 'src/Lib/*'),
            '@Utils': path.resolve(__dirname, 'src/Lib/utils.tsx'),
        }
    },
    output: {
        filename: 'bundle.js',
        path: path.resolve(__dirname, 'dist')
    }
};