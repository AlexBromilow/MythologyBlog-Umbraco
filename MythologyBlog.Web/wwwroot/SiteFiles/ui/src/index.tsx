import React from 'react';
import ReactDOM from 'react-dom/client';
import AccordionWidget from '@Widgets/Accordion/Accordion.widget';


if (document.querySelector("div[data-component=accordion]")) {
    const root = ReactDOM.createRoot(document.querySelector("div[data-component=accordion]"));
    root.render(<AccordionWidget />)
}



