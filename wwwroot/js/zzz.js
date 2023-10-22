var simplemde = new SimpleMDE({ element: document.getElementById("mde") });
console.log(1234)

const createHandler = () => {
    const ele = document.getElementById("create");
    if(!ele) return;
    ele.onclick = async () => {
        console.warn(simplemde.value());
        const rawResponse = await fetch('CreateCategoryContent', {
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(
                {
                    content: simplemde.value(),
                    cateName: "Apple",
                    title: document.getElementById("cateName").value,
                })
        });
        window.location.reload();
        
    }
}

const questionClick = () => {
    const tests = document.querySelectorAll(".test");
    tests.forEach(e => {
        const id = e.getAttribute("id");
        e.addEventListener("click", async () => {
            const params = new URLSearchParams({
                id
            });
            const response = await fetch("getquestion?" + params);
            const data = await response.json();
            simplemde.value(data.content);
            console.log(data);
        });
    })
}

const editHandler = () => {
    
        window.location.reload();
    
}

createHandler();
questionClick();
