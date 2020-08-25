function volumeEsfera(raio) {
  if (raio > 0) {
    // O volume é a medida que corresponde a quantidade de espaço
    // ocupado por um determinado objeto. Dito isso, o volume da
    // esfera refere-se ao espaço interno dessa figura geométrica,
    // sendo calculado a partir da fórmula Ve = 4. p. r³/3.
    return ((4 * Math.PI * Math.pow(raio, 3)) / 3);
  }
  return 0;
}

console.log(volumeEsfera(3));
module.exports = volumeEsfera;