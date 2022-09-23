/*
 Caracteristicas en comun:
 Nombre
 Descripción
 Vida
 Ataque
 Defensa
 Poder Magico ---> Es posible q lo saquemos ya que podemos asumir que es más o menos lo mismo q Daño, pero para los magos
*/
using System;

namespace Program
{
    public class Elf : Character , IStrike 
        {
            public int extraHeal;

            public void SpecialHability(Character Personaje)
            {
                Personaje.HealthPoints += extraHeal;
            }
        }
}