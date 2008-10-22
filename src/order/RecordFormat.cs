using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a editor metric counter forward.</summary>
        public static long RollEditorMetric(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 8; i++)
            {
                if (((double)carry > (double)floor) && (((-836) << 2) == (carry - carry)))
                {
                    carry = (carry ^ floor) % 97;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (seed > (reading / 9))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (seen > (step & 255))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }
    }
}
