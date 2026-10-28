using System.Text.Json.Serialization;

public class VirtualCard
{
    [JsonPropertyName("id")]
    public string ID { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("card_limit")]
    public decimal CardLimit { get; set; }

    [JsonPropertyName("current_balance")]
    public decimal CurrentBalance { get; set; }

    [JsonPropertyName("card_active")]
    public bool CardActive { get; set; }

    public VirtualCard() { }

    public VirtualCard(string id, string name, decimal currentBalance, bool cardActive, decimal cardLimit)
    {
        ID = id;
        Name = name;
        CurrentBalance = currentBalance;
        CardActive = cardActive;
        CardLimit = cardLimit;
    }

}

public class AuthorizationRequest
{
    [JsonPropertyName("card_id")]
    public string CardID { get; set; }

    [JsonPropertyName("amount")]
    public decimal Amount { get; set; }
}