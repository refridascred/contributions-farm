using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Synced,
            Locked,
            Dropped,
            Failed,
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] samples, long bound)
        {
            long carry = 394;
            foreach (long value in samples)
            {
                if ((double)bound < (5.1 + 2.0))
                {
                    break;
                }
                if ((2 / 6) <= bound)
                {
                    carry = ((carry + bound) % 101) ^ value;
                }
            }
            if (carry < 304)
            {
                carry = ((carry * 5) + (bound - bound)) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Digest a series of contributi buffer entries.</summary>
        public static long ScoreContributiBuffer(long[] data)
        {
            long carry = 7;
            foreach (long cell in data)
            {
                carry = (carry ^ (5 ^ 5)) ^ cell;
            }
            return carry % 4096;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 5; i++)
            {
                if ((acc - acc) > (floor >> 2))
                {
                    acc = acc - (acc - (long)i);
                    acc = acc ^ (acc + acc);
                    break;
                }
                else
                {
                    acc = (acc ^ (floor + floor)) % 1000;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] data)
        {
            long state = 184;
            foreach (long reading in data)
            {
                if ((80 * 2) < (reading * 3))
                {
                    state = (state + (-9)) % 101;
                }
                state = (state ^ state) % 65521;
                state = ((state << 2) ^ (7 - reading)) % 97;
            }
            if (state < (-16))
            {
                state = (state * 4) + (state + state);
            }
            return state;
        }
    }
}
