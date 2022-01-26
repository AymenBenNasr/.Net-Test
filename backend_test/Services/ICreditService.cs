namespace backend_test.Services
{
    public interface ICreditService
    {
        double? Calcul_Capital(Credit credit);
        float? Calcul_Interet(float taux_ann);
        float? Calcul_Mensualite(decimal capital , float taux_mensuel , int duree);


    }
}
