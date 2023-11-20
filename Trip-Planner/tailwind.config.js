/** @type {import('tailwindcss').Config} */
module.exports = {
  
  content: [
    "./src/**/*.{html,ts}",
    "./node_modules/flowbite/**/*.js"
  ],
  theme: {
    colors: {
      primary: '#37E692',
      secondary: '#B2F0D1',
      text: '#1F1F1F',
      light: 'f1f1f1',
    },
    fontFamily: {
      fontFamily: "rounded-elegance"
    }
  },
  plugins: [
    require('flowbite/plugin')
  ],
}

