export const getCookie = (name: string): string | null => {
    const cookies = document.cookie.split(';')

    for (const cookie of cookies) {
        const [key, value] = cookie.split('=');

        if (key === name) {
            return decodeURIComponent(value)
        }
    }

    return null;
}

export const setCookie = (name: string, value: string, expiry: number): void => {
    document.cookie = `${name}=${value};path=/;max-age=${expiry} `;
}

export const deletCookie = (name: string): void => {
    document.cookie = `${name}=;path=/;expires=Thu, 01 Jan 1970 00:00:00 GMT`;
}