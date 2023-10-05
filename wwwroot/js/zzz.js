var simplemde = new SimpleMDE();
console.log(1234)


document.getElementById("apply").onclick = async () => {
    console.warn(simplemde.value());
    const rawResponse = await fetch('Create', {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({markdown: simplemde.value(), name: "Textual content"})
    });
    window.location.reload();
}
