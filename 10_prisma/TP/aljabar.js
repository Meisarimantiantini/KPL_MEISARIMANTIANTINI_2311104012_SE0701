export function AkarPersamaanKuadrat(persamaan) {
    const [a, b, c] = persamaan;
    const D = b * b - 4 * a * c;
    if (D < 0) return ['Akar imajiner'];
    const akar1 = (-b + Math.sqrt(D)) / (2 * a);
    const akar2 = (-b - Math.sqrt(D)) / (2 * a);
    return [akar1, akar2];
}

export function HasilKuadrat(persamaan) {
    const [a, b] = persamaan;
    const A = a * a;
    const B = 2 * a * b;
    const C = b * b;
    return [A, B, C];
}
