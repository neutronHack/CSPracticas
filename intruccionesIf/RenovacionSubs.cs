/*
Le han pedido que agregue una característica al software de su empresa.
La característica está pensada para mejorar la tasa de renovación de las
suscripciones al software. Su tarea consiste en mostrar un mensaje de renovación
cuando un usuario inicia sesión en el sistema de software y se
notifica que su suscripción finaliza pronto. Para cumplir los requisitos,
necesitará agregar un par de instrucciones de decisión para agregar lógica
de rama a la aplicación.
*/


public class RenovacionSubs
{
    public void subs()
    {

        Random random = new Random();
        int diasHastaExpiracion = random.Next(12);
        int porcentajeDeDescuento = 0;

        if (diasHastaExpiracion == 0)
        {
            Console.WriteLine("Su suscripción ha expirado.");
        }
        else if (diasHastaExpiracion == 1)
        {
            Console.WriteLine($"¡Tu suscripción vence en un día! ¡Renueva ahora y ahorra un 20 %!");
            porcentajeDeDescuento = 20;
        }
        else if (diasHastaExpiracion <= 5)
        {
            Console.WriteLine("Tu suscripción vence en {diasHastaExpiracion} días. ¡Renueva ahora y ahorra un 10 %!");
            porcentajeDeDescuento = 10;
        }
        else if (diasHastaExpiracion <= 10)
        {
            Console.WriteLine("Tu suscripción expirará pronto. ¡Renueva ahora!");
        }
        if (porcentajeDeDescuento > 0)
        {
            Console.WriteLine($"Renueva ahora y ahorra {porcentajeDeDescuento}%.");
        }
    }
}
