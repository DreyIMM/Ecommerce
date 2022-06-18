//Selecionaod as requisições
const DropArea = document.querySelector(".drag-area");
let file;


//Se o usuario drag um arquivo na DropArea
DropArea.addEventListener("dragover", (event) => {
    event.preventDefault();
    DropArea.classList.add("active");
    
   
})

//Se o usuario sair dragged um arquivo na DropArea
DropArea.addEventListener("dragleave", () => {
    DropArea.classList.remove("active");

})

//Se o usuario dropar um arquivo na DropArea
DropArea.addEventListener("drop", (event) => {
    event.preventDefault();
    file = event.dataTransfer.files[0];
    let fileType = file.type;
    typeFile(fileType);

})



//Validando o tipo de arquivo
const typeFile = (fileType) => {
    validExtensions = ["image/jpeg", "image/jpg", "image/png"];
    if (validExtensions.includes(fileType)) {
        console.log(fileType);

    } else {
        console.log("erro"+fileType);

    };
}