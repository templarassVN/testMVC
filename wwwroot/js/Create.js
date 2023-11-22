const addButton = document.getElementById("add");
const testArea = document.getElementById("test");
const newQuest = document.getElementById("new");
let cnt= 0;
const deleteHandler = () => {
    const allDelete = testArea.querySelectorAll("div[data-id]");
    allDelete.forEach(input => {
        const deleteButton = input.querySelector('button[for="delete"]');
        deleteButton.onclick = function () {
            input.parentNode.removeChild(input);
        }
        const approveButton = input.querySelector('button[for="true"]');
        approveButton.onclick = function () {
            input.classList.toggle("bg-green-400");
        }
    })
}

addButton.onclick = function () {
    const tmp = newQuest.cloneNode(true);
    tmp.classList.toggle("hidden");
    tmp.setAttribute("data-id", `$ans-${cnt++}`)
    testArea.appendChild(tmp);
    deleteHandler();
}