import { deletCookie, getCookie, setCookie } from "../Helpers/CookieHelper";

const darkModeCookieName = 'dark-mode';
const htmlTag = document.querySelector('html');
const darkModeCheckbox = document.querySelector('.js-dark-chekbox') as HTMLInputElement;

const initDarkMode = () => {

    const darkCookie = getCookie(darkModeCookieName);

    if (darkCookie) {
        darkModeCheckbox.checked = true;
        if (!htmlTag?.classList.contains('dark')) {
            htmlTag?.classList.add('dark');
        }
    }

    const darkModeToggle = document.querySelector('.js-toggle-dark');

    if (!darkModeToggle) {
        return;
    }

    darkModeToggle.addEventListener('click', e => handleToggle(e));
}

const handleToggle = (e: Event) => {
    const darkCookie = getCookie(darkModeCookieName)
    if (darkCookie) {
        // Delete cookie
        deletCookie(darkModeCookieName);
        // remove dark class
        htmlTag?.classList.remove('dark');
        return;
    }

    // Add cookie
    setCookie(darkModeCookieName, 'true', 2592000)
    // add dark class
    htmlTag?.classList.add('dark');
    return;
}

export default initDarkMode;