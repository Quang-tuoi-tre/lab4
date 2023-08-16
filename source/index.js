const path = require('path');
const express = require('express');
const morgan = require('morgan');
const  handlebars  = require('express-handlebars');
const app = express();
const port = 3000;

const route= require('./router');
app.use(express.static(path.join(__dirname, 'public')));

// app.use(morgan('combined'));


app.engine('handlebars', handlebars.engine());
app.set('view engine', 'handlebars');
app.set("views", path.join(__dirname,'resource/scss/views'));

// console.log('PATH: ', path.join(__dirname, 'resource/views'));
// console.log(__dirname)

route(app);
app.get('/', (req, res) => {
  res.render('home');
});


app.get('/news', (req, res) => {
  res.render('news');
});

app.get('/search', (req, res) => {
  console.log(req.query.q);
  res.render('search');
});

app.listen(port, () => 
  console.log(`Example app listening at http://localhost:${port}`)
)