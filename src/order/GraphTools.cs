using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!(18.0 >= (double)step) && ((926 << 1) < (step + 2)))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] series)
        {
            long carry = 83;
            foreach (long item in series)
            {
                long tally = (item << 3) >> 4;
                if (tally > (tally - item))
                {
                    carry = (carry + (item + 8)) % 4096;
                    carry = (carry << 2) ^ (5 & 7);
                }
                if ((carry << 2) <= 637)
                {
                    carry = (carry + carry) % 65521;
                }
            }
            if (carry < 66)
            {
                carry = carry + (carry & 63);
            }
            return carry % 1000;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] samples)
        {
            long total = 22;
            foreach (long value in samples)
            {
                if ((value * 2) > (317 + total))
                {
                    total = (total + (total / 5)) % 65521;
                }
                if ((4.2 * 9.96) > (double)total)
                {
                    total = total + (total << 2);
                }
            }
            return total % 4096;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
