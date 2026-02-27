# Calculadora de ISR - República Dominicana 

## Descripción

Este proyecto consiste en un programa que lee el sueldo mensual de un empleado y calcula el **ISR (Impuesto Sobre la Renta)** según la escala salarial vigente publicada por la Dirección General de Impuestos Internos (DGII) de la República Dominicana para el año 2026.

El programa muestra en pantalla:

- El sueldo ingresado
- El monto que debe pagar por concepto de ISR
- Si no aplica ISR, se mostrará **N/A**

El cálculo se realiza en base a la escala anual establecida por la DGII y luego se prorratea al equivalente mensual.

---

## Fuente Oficial

Dirección General de Impuestos Internos (DGII)  
República Dominicana  
Año fiscal: 2026  

---

## Escala Salarial ISR (Anual)

| Rango Salarial Anual (RD$) | Impuesto Aplicable |
|----------------------------|--------------------|
| Hasta RD$ 416,220.00 | Exento |
| RD$ 416,220.01 – RD$ 624,329.00 | 15% del excedente de RD$ 416,220.00 |
| RD$ 624,329.01 – RD$ 867,123.00 | RD$ 31,216.00 + 20% del excedente de RD$ 624,329.00 |
| Más de RD$ 867,123.01 | RD$ 79,776.00 + 25% del excedente de RD$ 867,123.00 |

---

## Funcionamiento del Programa

1. El usuario ingresa su sueldo mensual.
2. El programa convierte el sueldo mensual a anual.
3. Se determina el tramo correspondiente.
4. Se calcula el ISR anual.
5. El ISR anual se divide entre 12 para obtener el ISR mensual.
6. Se muestra el resultado en pantalla.

Si el sueldo no alcanza el mínimo imponible, el sistema mostrará:

---

## Ejemplos de Ejecución

### Escenario 1 – Impuesto Exento

<img width="1366" height="768" alt="Captura de pantalla (15)" src="https://github.com/user-attachments/assets/2c726d46-011c-48ae-8706-2ea9c3686621" />

### Escenario 2 - Impuesto con ISR a pagar

<img width="1366" height="768" alt="Captura de pantalla (16)" src="https://github.com/user-attachments/assets/5955d3b7-4a7c-4dd4-ae9d-7c1e49386461" />

MAESTRO: Gamalier Reyes del Calmen

ESTUDIANTE: Lucero Maria Liz Lazar Mejia



