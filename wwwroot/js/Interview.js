
document.getElementById("test").addEventListener("click", async () =>{
    // const response = await fetch("Home/TestComponent?data=A", {method : "GET"});
    const response = await fetch("Home/Filter?data=A", {method : "GET"});
    const text = await response.text();
    document.getElementById("testResult").innerHTML = text;
})

const a = document.querySelectorAll('.question');
a?.forEach(e => {
    e.addEventListener('click', () => {
        hightLightQuestion(e);
    })
})

const hightLightQuestion = (clickedE) => { 
    const normal = "question block w-full px-4 py-2 border-b border-gray-200 cursor-pointer hover:bg-gray-100 hover:text-blue-700 focus:outline-none focus:ring-2 focus:ring-blue-700 focus:bg-sky-700 dark:border-gray-600 dark:hover:bg-gray-600 dark:hover:text-white dark:focus:ring-gray-500 dark:focus:text-white"; 
    const chosen = "question w-full px-4 py-2 font-medium text-left text-white bg-blue-700 border-b border-gray-200 rounded-t-lg cursor-pointer focus:outline-none dark:bg-gray-800 dark:border-gray-600";
    a?.forEach(e => 
        e?.className = normal)
    clickedE?.className = chosen;
}
