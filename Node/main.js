var http = require('http')
var os = require('os')
var fs = require('fs')
var url = require('url')
var util = require('util')
var crypto = require('crypto')
var events = require('events')

var testMD = require('./moduletest1') // export 테스트

// 로컬 서버 띄우기
http.createServer(function (request, response){
    response.writeHead(200, { 'Content-Type': 'text/html'});
    response.end('<h1>Hello World</h1>');
}).listen(52273, function(){
    console.log('Server running at http://127.0.0.1');
});

console.log('haddongik')

process.argv.forEach(function (item, index){
    console.log(item + ' ' + index);
})

console.log( testMD.abs(-100) );

var testString = util.format('%d + %d', 10, 20);
console.log( testString )

var key = 'haddongik' // 클라/서버 공유 키
var password = 'ok3850328'

// 암호화
var cipher = crypto.createCipher('aes192', key)
cipher.update(password, 'utf8', 'base64')
var cipherOutput = cipher.final('base64')

console.log('password : ' + password)
console.log('ciphered : ' + cipherOutput)

// 프로세스에 이벤트 연결
process.on('ttt', function(code){
    console.log('event test : ' + code)
});

process.emit('ttt', 'hehe')

// 커스텀 리스너
var customHandler = new events.EventEmitter();