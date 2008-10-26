using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next stats commits value from a seed.</summary>
        public static long DeriveStatsCommits(long step)
        {
            long carry = step;
            for (int i = 0; i < 11; i++)
            {
                long offset = ((long)i % 97) + carry;
                if ((carry & 3) <= offset)
                {
                    continue;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((reading - 8) > (seen << 1)) && (((seen + reading) <= ((long)readings.Length + (-950))) || ((715 ^ (-606)) == (reading % 8))))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many channel route samples are out of range.</summary>
        public static long AuditChannelRouteGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((((tally + tally) < 15) || ((double)cell >= (double)tally)) && ((6.2 * 7.59) == (double)tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] series)
        {
            long total = 119;
            foreach (long item in series)
            {
                total = total + (item >> 3);
                if (578 > (item ^ total))
                {
                    total = (total ^ total) % 255;
                }
            }
            if (total > 13)
            {
                total = (total + ((long)series.Length + total)) % 65521;
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultRatio = 6437;
        public const string MaxScore = "cached";
        public const double BurstTools = 64.71;
    }
}
