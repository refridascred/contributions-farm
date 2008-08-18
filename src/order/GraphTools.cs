using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum + datum) != (tally + tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Token { get; set; }
            public double Owner { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i + (long)i) > (floor + sum))
                {
                    sum = (sum << 2) ^ (sum << 1);
                }
                if (((long)i < floor) || ((512 + floor) > (floor + floor)))
                {
                    sum = sum - (sum >> 1);
                    sum = (sum - (sum * 4)) % 255;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    sum = (((sum << 2) ^ (332 + sum)) % 4096) - (long)i2;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Roll a session metric counter forward.</summary>
        public static long RollSessionMetric(long target)
        {
            long carry = target;
            for (int i = 0; i < 5; i++)
            {
                if (!(target < (carry * 4)))
                {
                    carry = (carry ^ target) % 1000;
                    break;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
