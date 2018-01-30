namespace kaffe
{
    public class FlatWhite : Kaffe, Imælk

    {
        /// <summary>
        /// Hvor meget mælk der skal bruges til en FlatWhite
        /// </summary>
        /// <returns></returns>
        public int MlMælk()
        {
            return 165;
        }

        /// <summary>
        /// Hvor meget en FlatWhite skal koste
        /// </summary>
        /// <returns></returns>
        public override int Pris()
        {
            return 45;
        }

        /// <summary>
        /// Hvilken styrke FlatWhite skal have. Da der er meget mælk, er kaffen mild. 
        /// </summary>
        /// <returns></returns>
        public override string Styrke()
        {
            return "Mild";
        }
    }
}