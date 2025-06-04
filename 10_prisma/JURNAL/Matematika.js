export function FPB(a, b) {
    while (b !== 0) {
        const temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}

export function KPK(a, b) {
    return (a * b) / FPB(a, b);
}

export function Turunan(persamaan) {
    const derajat = persamaan.length - 1;
    const hasil = [];

    for (let i = 0; i < persamaan.length - 1; i++) {
        const pangkat = derajat - i;
        const koef = persamaan[i];
        const hasilKoef = koef * pangkat;

        if (hasilKoef === 0) continue;

        let suku = "";
        if (pangkat - 1 === 0) suku = `${hasilKoef}`;
        else if (pangkat - 1 === 1) suku = `${hasilKoef}x`;
        else suku = `${hasilKoef}x^${pangkat - 1}`;

        hasil.push(suku);
    }

    return hasil.join(" + ").replace(/\+\s\-/g, "- ");
}

export function Integral(persamaan) {
    const derajat = persamaan.length - 1;
    const hasil = [];

    for (let i = 0; i < persamaan.length; i++) {
        const koef = persamaan[i];
        const pangkatBaru = derajat - i + 1;
        const hasilKoef = koef / pangkatBaru;

        let suku = "";
        if (pangkatBaru === 1) suku = `${hasilKoef}x`;
        else suku = `${hasilKoef}x^${pangkatBaru}`;

        hasil.push(suku);
    }

    return hasil.join(" + ") + " + C";
}
