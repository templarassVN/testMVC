import * as flowbite from "flowbite"

flowbite.initAccordions();
console.log(interact(".content").resizable)
interact("#content").resizable({
    edges: { right: true },
    modifiers: [
        interact.modifiers.restrictSize({
            min: { width: 200 }, // Set the minimum width to 100 pixels
            max: { width: 500 }, // Set the maximum width to 500 pixels
        }),
    ],
    listeners: {
        move: function (event) {
            let { x, y } = event.target.dataset

            x = (parseFloat(x) || 0) + event.deltaRect.left
            y = (parseFloat(y) || 0) + event.deltaRect.top

            Object.assign(event.target.style, {
                width: `${event.rect.width}px`,
                height: `${event.rect.height}px`,
                transform: `translate(${x}px, ${y}px)`
            })

            Object.assign(event.target.dataset, { x, y })
        }
    }
})