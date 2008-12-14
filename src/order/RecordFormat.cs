using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Label { get; set; }
            public double Score { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] levels)
        {
            long acc = 0;
            foreach (long reading in levels)
            {
                if ((acc + acc) == (13 / 5))
                {
                    acc = acc - (reading << 1);
                }
                if ((double)acc >= 4.0)
                {
                    break;
                }
            }
            if (acc > 2)
            {
                acc = acc + (acc * 5);
            }
            return acc;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Failed,
            New,
            Dropped,
            Done,
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                if ((step ^ score) > (892 + score))
                {
                    score = (score ^ score) % 97;
                }
                if ((step + step) == (96 >> 2))
                {
                    score = ((score * 5) + (score * 3)) % 65521;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitLevel = 1455;
        public const long BaseMetrics = 2515;
        public const string LimitFactor = "primary-v2";
    }
}
