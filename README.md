🚀 DIO - Trilha .NET - Explorando a Linguagem C#
www.dio.me

📋 Desafio de Projeto
Este projeto faz parte do módulo Explorando a Linguagem C# da trilha .NET da DIO. O objetivo foi construir um sistema de hospedagem para um hotel, permitindo a realização de reservas e o cálculo do valor total da estadia com base em regras específicas.

🌟 Contexto
O sistema de hospedagem desenvolvido inclui as seguintes classes:

Classe Pessoa: Representa o hóspede com atributos como nome e sobrenome.
Classe Suíte: Representa a suíte do hotel, com atributos como capacidade e valor da diária.
Classe Reserva: Faz a relação entre hóspedes e suíte, além de calcular o valor total da reserva.

🏁 O que foi Implementado
Verificação de Capacidade de Hóspedes: Implementado um controle na classe Reserva para garantir que o número de hóspedes não exceda a capacidade da suíte. Caso contrário, uma exceção é lançada.
Cálculo da Quantidade de Hóspedes: O método ObterQuantidadeHospedes foi implementado para retornar a quantidade total de hóspedes corretamente.
Cálculo do Valor da Diária: O método CalcularValorDiaria foi implementado para calcular o valor total da diária com base no número de dias reservados. Um desconto de 10% é aplicado automaticamente para reservas de 10 dias ou mais.

🔍 Regras e Validações
❌ Capacidade Insuficiente: O sistema agora impede a reserva de uma suíte com capacidade menor do que o número de hóspedes.
👥 Quantidade de Hóspedes: O método ObterQuantidadeHospedes retorna a quantidade correta de hóspedes cadastrados na reserva.
💵 Cálculo do Valor Total da Diária: O método CalcularValorDiaria calcula o valor corretamente, aplicando o desconto de 10% quando a reserva é de 10 dias ou mais.

![Diagrama de classe estacionamento](diagrama_classe_hotel.png)

📝 Conclusão
O sistema de hospedagem foi implementado com sucesso, respeitando todas as regras e validações especificadas. As funcionalidades foram testadas e confirmadas conforme esperado, garantindo a correta operação do sistema.

O código final está totalmente funcional e pronto para ser utilizado em um ambiente de produção.

😊 Status do Projeto: Concluído com Sucesso!