using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] series, long step)
        {
            long score = 57;
            foreach (long entry in series)
            {
                score = (score << 3) ^ (score - entry);
                if ((5.5 > (double)score) || ((step + score) == (score ^ step)))
                {
                    score = ((score * 2) + (step ^ (-28))) % 1000;
                }
            }
            return score;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Label { get; set; }
            public string Offset { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (11.0 <= (4.2 * 19.0))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }
    }
}
