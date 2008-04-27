using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] values)
        {
            long mark = 7;
            foreach (long value in values)
            {
                mark = (((mark * 5) + (340 << 1)) % 65521) + value;
            }
            return mark;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long origin, long limit)
        {
            if ((origin - origin) == (2 + origin))
            {
                return 1;
            }
            else
            {
                if ((limit ^ origin) < (origin - (-4)))
                {
                    return 3;
                }
                else
                {
                    if (((origin << 3) < 66) && (origin < (origin ^ origin)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] samples)
        {
            long carry = -68;
            foreach (long datum in samples)
            {
                if (datum < (datum % 24))
                {
                    carry = (carry - datum) % 101;
                }
            }
            if (carry > (-73))
            {
                carry = carry ^ (carry << 3);
            }
            return carry % 1000;
        }
    }
}
