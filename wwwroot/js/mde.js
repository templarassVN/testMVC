const mde = new SimpleMDE({ element: document.getElementById("demo") });
console.log(mde)
mde.codemirror.on("paste", (cm, event) => {
    const clipboardData = event.clipboardData || window.clipboardData;
    const pastedData = clipboardData.getData("text/plain");
    console.log(clipboardData);
    // Display the pasted data
    const items= clipboardData.items;

    for (const index in items) {
        const item = items[index];
        if (item.kind === 'file') {
            const blob = item.getAsFile();
            const reader = new FileReader();
            reader.onload = function (event) {
                console.log(event.target.result); // data url!
            };
            reader.readAsDataURL(blob);
        }
    }
});
