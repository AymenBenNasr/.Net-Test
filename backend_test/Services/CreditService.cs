namespace backend_test.Services
{
    public class CreditService : ICreditService
    {
        public double? Calcul_Capital(Credit credit)
        {
            double montant_emprunt_brut = credit.montant_achat - credit.fonds_propres + (credit.montant_achat*0.1) ;

            return montant_emprunt_brut + (montant_emprunt_brut * 0.02);
            
        }

        public float? Calcul_Interet(float taux_ann)
        {
            throw new NotImplementedException();
        }

        public float? Calcul_Mensualite(decimal capital, float taux_mensuel, int duree)
        {
            throw new NotImplementedException();
        }

    }
}
