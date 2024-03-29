using JetBrains.Annotations;
using Robust.Shared.IoC;
using Robust.Shared.Random;
using Robust.Shared.Serialization.Manager.Attributes;

namespace Content.Server.Maps.NameGenerators;

[UsedImplicitly]
public class SolgovNameGenerator : GameMapNameGenerator
{
    /// <summary>
    ///     Where the map comes from. Should be a two or three letter code, for example "VG" for Packedstation.
    /// </summary>
    [DataField("prefixCreator")] public string PrefixCreator = default!;

    private string Prefix => "SOL";

    // S1 and S2 are special.
    private string[] SuffixCodes => new []{ "S3", "S4", "S5", "S6", "S7" };

    public override string FormatName(string input)
    {
        var random = IoCManager.Resolve<IRobustRandom>();

        // No way in hell am I writing custom format code just to add nice names. You can live with {0}
        return string.Format(input, $"{Prefix}{PrefixCreator}", $"{random.Pick(SuffixCodes)}-{random.Next(0, 999):D3}");
    }
}
