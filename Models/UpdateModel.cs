namespace contact_manager_dot_net.Models
{
    public class UpdateModel
    {
        public DatabaseResponseModel UpdateValue { get; set; }
        public string Id { get; set; }
        public DatabaseResponseModel NewValue { get; set; }
    }
}
