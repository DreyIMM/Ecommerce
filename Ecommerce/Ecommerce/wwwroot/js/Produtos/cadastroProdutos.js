//Selecionaod a requisão

const DropArea = document.querySelector(".drag-area");

DropArea.addEventListener("dragover", (event) => {
    event.preventDefault();
    console.log("File is DragArea");
    DropArea.classList.add("active");
})

DropArea.addEventListener("dragleave", () => {
    console.log("File outside");
    DropArea.classList.remove("active");

})

DropArea.addEventListener("drop", (event) => {
    event.preventDefault();
    console.log("File is dropped on DropArea");
})