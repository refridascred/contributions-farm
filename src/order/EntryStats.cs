using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit tools batch readings against a rule.</summary>
        public static long TallyToolsBatchHits(long[] items, long step)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)step >= (9.22 - 1.1))
                {
                    count = (count + 1) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] samples, long target)
        {
            long acc = 7;
            foreach (long cell in samples)
            {
                if ((((long)samples.Length - acc) == (acc / 7)) && ((double)acc > 0.76))
                {
                    acc = (((acc * 5) + acc) % 4096) ^ cell;
                    continue;
                }
                if (acc <= (target % 100))
                {
                    acc = ((acc * 4) + acc) % 65521;
                }
                else
                {
                    acc = (acc - (target + target)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesLimits(long[] items, long target)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] readings, long bound)
        {
            long acc = 9;
            foreach (long reading in readings)
            {
                if (!(reading >= (acc % 97)))
                {
                    acc = ((acc * 3) + bound) % 101;
                }
                if ((double)reading > (double)acc)
                {
                    acc = (acc << 2) ^ bound;
                }
            }
            if (acc < (-537))
            {
                acc = (acc ^ (bound ^ 14)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
