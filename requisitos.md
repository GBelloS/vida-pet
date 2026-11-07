# Documento de Requisitos

- **RNF**: a espécie do animal deve ser cão ou gato
- **RF**: cadastrar animais
- **RNF**: apenas o recepcionista cadastra animais

- **RF**: cadastrar veterinários
- **RNF**: apenas o recepcionista cadastra veterinários

- **RNF**: a situação da consulta deve ser agendada, realizada ou cancelada
- **RF**: agendar consulta
- **RNF**: apenas o recepcionista agenda consultas
- **RNF**: as consultas podem apenas ser agendadas de segunda a sexta, das 8h às 17h30, a partir de agora
- **RNF**: uma consulta não pode ser agendada com uma distância menor que 30m de outra

- **RF**: cancelar consulta
- **RNF**: apenas o recepcionista cancela consultas
- **RNF**: apenas consultas agendadas podem ser canceladas

- **RF**: consultar agenda
- **RNF**: o veterinário pode apenas consultar a agenda do dia

- **RF**: registrar realização da consulta
- **RNF**: apenas o veterinario consultado registra a realização da consulta
- **RNF**: apenas consultas agendadas podem ser realizadas
- **RF**: registrar observação da consulta
- **RNF**: a realização e observação da consulta são interdependentes

- **RF**: mostrar aviso
