using BetterSort.Common.External;
using System.Text.Json.Serialization;

namespace BetterSort.Accuracy.External {

  public class BestRecord {
    public double Accuracy { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter<RecordDifficulty>))]
    public RecordDifficulty Difficulty { get; set; }

    public string Mode { get; set; } = "";
    public int Score { get; set; }
    public string SongHash { get; set; } = "";
  }
}
