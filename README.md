# RESISTENZA DI UN NUMERO

La "resistenza" di un numero indica quante volte puoi ricorsivamente moltiplicare le sue cifre, prima di ottenere un numero di una sola cifra.

Per fare un esempio, calcoliamo la resistenza del numero 882:

- Se si moltiplicano tutte le cifre del numero 882 si ottiene 128 (8 * 8 * 2).
- Ripetendo l'operazione per 128 si ottiene 16 (1 * 2 * 8).
- Ripetendo l'operazione per 16 si ottiene 6 (1 * 6).
- 6 è di una sola cifra, quindi ci fermiamo qui.

Dato che siamo riusciti a ripetere l'operazione per 3 volte, diciamo che 882 ha una "resistenza" di 3.

## Esempi:

- `getResistenza(39)` restituisce 3.
- `getResistenza(77)` restituisce 4.
- `getResistenza(1679)` restituisce 5.
- `getResistenza(6788)` restituisce 6.

## Trovare un numero con resistenza di almeno 7

Riesci a trovare un numero con una resistenza di almeno 7? Se sì, come hai fatto?
vedi codice funzione `SearchSevenResult()`, ho fatto un while che si ferma alla prima occorenza del numero che trova
---

# FREQUENZA DI UN NUMERO

Nell'array di interi `[55, 42, 88, 42, 88, 42]`, il numero 88 è presente 2 volte. Diciamo quindi che 88 ha una "frequenza" di 2. Nello stesso array, il numero più frequente è il 42 (con una frequenza di 3).

## Esempi:

1. Scrivi una funzione `getMaxFrequente(array)` che restituisca il numero più frequente in un array di interi passato come argomento. Nel caso in cui ci siano più numeri con la stessa frequenza massima, restituisci il più piccolo.

    - `getMaxFrequente([55, 42, 88, 42, 88, 42])` restituisce 42.
    - `getMaxFrequente([1, 52, 52, 1, 56, 1, 54, 54, 1, 54])` restituisce 1.
    - `getMaxFrequente([52, 52, 52, 56, 54, 54, 54])` restituisce 52 (infatti 52 e 54 hanno entrambi una frequenza di 3, ma 52 è il numero più piccolo).

2. Scrivi una funzione `getMaxFrequenti(array, k)` che restituisca un array contenente i primi k numeri più frequenti in un array di interi passato come argomento. Anche qui, in caso di pareggio di frequenze, restituisci i numeri minori per primi.

    - `getMaxFrequenti([1, 52, 52, 52, 1, 56, 1, 54, 54, 1, 54], 1)` restituisce `[1]`.
    - `getMaxFrequenti([1, 52, 52, 52, 1, 56, 1, 54, 54, 1, 54], 2)` restituisce `[1, 52]`.
    - `getMaxFrequenti([1, 52, 52, 52, 1, 56, 1, 54, 54, 1, 54], 3)` restituisce `[1, 52, 54]`.

---
