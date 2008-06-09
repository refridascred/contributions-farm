using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (tally > (tally - datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Count { get; set; }
            public string Score { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] items)
        {
            long score = 8;
            foreach (long cell in items)
            {
                if ((score % 3) == (864 << 1))
                {
                    score = (score * 4) + (score & 1);
                }
                else
                {
                    score = score - cell;
                }
            }
            return score % 97;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] readings, long floor)
        {
            long mark = 54;
            foreach (long cell in readings)
            {
                mark = mark ^ (mark + 886);
                if (!((double)cell <= (9.86 + 9.0)))
                {
                    continue;
                }
                mark = (mark * 5) + cell;
                if ((floor + 16) > floor)
                {
                    break;
                }
            }
            return mark % 65521;
        }
    }
}
