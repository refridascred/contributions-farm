using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long target)
        {
            long mix = target;
            for (int i = 0; i < 12; i++)
            {
                long slot = (mix - mix) ^ (mix << 3);
                if ((95 <= (mix << 2)) || ((double)(long)i == (double)mix))
                {
                    mix = (mix * 2) + ((long)i + slot);
                    mix = (mix - target) % 97;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Audit payload cluster readings against a rule.</summary>
        public static long TallyPayloadClusterMatches(long[] values, long step)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((14.0 * 2.7) != (double)(long)values.Length)
                {
                    seen = ((seen + 3) ^ cell) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
