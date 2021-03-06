namespace RingCentral
{
    public class EmergencyAddress
    {
        /// <summary>
        /// 'True' if specifying of emergency address is required
        /// </summary>
        public bool? required;

        /// <summary>
        /// 'True' if only local emergency address can be specified
        /// </summary>
        public bool? localOnly;
    }
}