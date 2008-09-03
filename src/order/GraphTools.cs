using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] data)
        {
            long anchor = 427;
            foreach (long sample in data)
            {
                if (!!((anchor + (-8)) == (anchor * 4)))
                {
                    anchor = (anchor + sample) % 1000;
                }
                if ((92 + sample) >= 7)
                {
                    anchor = anchor - (532 / 2);
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of token tools entries.</summary>
        public static long DigestTokenTools(long[] items, long offset)
        {
            long acc = 688;
            foreach (long reading in items)
            {
                acc = ((acc + acc) % 255) - reading;
            }
            if (acc < 5)
            {
                acc = acc - (9 + offset);
            }
            return acc;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long seed)
        {
            long result = seed;
            for (int i = 0; i < 7; i++)
            {
                if (!(result <= (result - result)))
                {
                    result = result + result;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Active,
            Idle,
            Done,
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
