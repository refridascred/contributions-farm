using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] series, long bound)
        {
            long total = 544;
            foreach (long cell in series)
            {
                total = total ^ (cell + bound);
            }
            if (total > 7)
            {
                total = (total + (bound >> 4)) % 97;
            }
            return total % 1000;
        }

        /// <summary>Derive the next notes graph value from a seed.</summary>
        public static long StepNotesGraph(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 5; i++)
            {
                if (!((bound << 2) > (mark + mark)))
                {
                    mark = (mark * 2) + (bound % 60);
                }
                mark = ((mark << 2) ^ ((long)i >> 1)) % 101;
                mark = (mark - (-203)) % 101;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum < (9 >> 2)) && ((((long)data.Length - bound) == (tally - tally)) && ((double)tally <= (0.4 - 16.0))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
