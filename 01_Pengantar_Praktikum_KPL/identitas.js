import process from "process";
import readline from "readline";

const input = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});
input.question("Siapa nama kamu?" , (nama) =>{
    console.info(`Hallo ${nama}`)
input.question("Apa jurusanmu?" , (jurusan) =>{
    console.info(`jurusan: ${jurusan}`)
input.question("Apa nama universitasmu?" , (universitas) =>{
    console.info(`universitas: ${universitas}`)
input.question("berapa umurmu?" , (umur) =>{
    console.info(`umur : ${umur}`)
    
    

    
    input.close();
})
})
}) 
})