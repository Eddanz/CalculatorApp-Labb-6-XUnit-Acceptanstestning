# Acceptanstest för Kalkylatorapplikation

## Test: Addition_ReturnsCorrectResult

### Steg-för-steg instruktioner:
1. Öppna kalkylatorapplikationen.
2. Ange första talet (x) i det första inmatningsfältet.
3. Ange andra talet (y) i det andra inmatningsfältet.
4. Klicka på knappen för addition.
5. Notera resultatet som visas.

### Förväntat resultat:
- Om x = 1.0 och y = 2.0, ska applikationen visa resultatet 3.0.
- Om x = 10.5 och y = 5.5, ska applikationen visa resultatet 16.0.
- Om x = -1.5 och y = -2.5, ska applikationen visa resultatet -4.0.
- Om x = 100.0 och y = 200.0, ska applikationen visa resultatet 300.0.
- Om x = 0.0 och y = 0.0, ska applikationen visa resultatet 0.0.

## Test: Subtraction_ReturnsCorrectResult

### Steg-för-steg instruktioner:
1. Öppna kalkylatorapplikationen.
2. Ange första talet (x) i det första inmatningsfältet.
3. Ange andra talet (y) i det andra inmatningsfältet.
4. Klicka på knappen för subtraktion.
5. Notera resultatet som visas.

### Förväntat resultat:
- Om x = 5.0 och y = 3.0, ska applikationen visa resultatet 2.0.
- Om x = 10.5 och y = 5.5, ska applikationen visa resultatet 5.0.
- Om x = -1.5 och y = -2.5, ska applikationen visa resultatet 1.0.
- Om x = 100.0 och y = 50.0, ska applikationen visa resultatet 50.0.
- Om x = 0.0 och y = 0.0, ska applikationen visa resultatet 0.0.

## Test: Multiplication_ReturnsCorrectResult

### Steg-för-steg instruktioner:
1. Öppna kalkylatorapplikationen.
2. Ange första talet (x) i det första inmatningsfältet.
3. Ange andra talet (y) i det andra inmatningsfältet.
4. Klicka på knappen för multiplikation.
5. Notera resultatet som visas.

### Förväntat resultat:
- Om x = 2.0 och y = 3.0, ska applikationen visa resultatet 6.0.
- Om x = 10.5 och y = 2.0, ska applikationen visa resultatet 21.0.
- Om x = -1.5 och y = 2.0, ska applikationen visa resultatet -3.0.
- Om x = 100.0 och y = 0.0, ska applikationen visa resultatet 0.0.
- Om x = 0.0 och y = 0.0, ska applikationen visa resultatet 0.0.

## Test: Division_ReturnsCorrectResult

### Steg-för-steg instruktioner:
1. Öppna kalkylatorapplikationen.
2. Ange första talet (x) i det första inmatningsfältet.
3. Ange andra talet (y) i det andra inmatningsfältet.
4. Klicka på knappen för division.
5. Notera resultatet som visas.

### Förväntat resultat:
- Om x = 6.0 och y = 3.0, ska applikationen visa resultatet 2.0.
- Om x = 21.0 och y = 2.0, ska applikationen visa resultatet 10.5.
- Om x = -3.0 och y = 2.0, ska applikationen visa resultatet -1.5.
- Om x = 100.0 och y = 25.0, ska applikationen visa resultatet 4.0.
- Om x = 0.0 och y = 1.0, ska applikationen visa resultatet 0.0.

## Test: Division_DivideByZero_ReturnsZero

### Steg-för-steg instruktioner:
1. Öppna kalkylatorapplikationen.
2. Ange första talet (x = 10.0) i det första inmatningsfältet.
3. Ange andra talet (y = 0.0) i det andra inmatningsfältet.
4. Klicka på knappen för division.
5. Notera resultatet och meddelandet som visas.

### Förväntat resultat:
- Applikationen ska visa resultatet 0.
- Applikationen ska visa meddelandet "10.0 / 0.0 = Cannot divide by zero."
