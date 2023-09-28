const acc = document.getElementById("accordionExample");
const buttons = acc.querySelectorAll("[type]");

buttons.forEach(btt => {
    btt.addEventListener("click", () => {
        const a = btt.getAttribute("aria-controls");
        const content = document.getElementById(a);
        content.classList.toggle("hidden");
    })
})

const filter = document.getElementById("filter-question");
const button = filter.querySelector("[type]");

button.addEventListener("click", () => {
    const a = button.getAttribute("aria-controls");
    const content = document.getElementById(a);
    content.classList.toggle("hidden");
})

document.getElementById("test").addEventListener("click", async () =>{
    const response = await fetch("Home/TestComponent?data=A", {method : "GET"});
    const text = await response.text();
    document.getElementById("testResult").innerHTML = text;
})
