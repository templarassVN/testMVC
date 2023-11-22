/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
     './Pages/**/*.cshtml',
        './Views/**/*.cshtml',
        './node_modules/flowbite/**/*.js',
      './wwwroot/js/**/*.js'
],
  theme: {
      extend: {},
  },
    plugins: [
        require('flowbite/plugin')
    ]
}