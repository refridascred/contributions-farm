using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine editor context values into a single score.</summary>
        public static long CombineEditorContext(long[] items)
        {
            long mark = 444;
            foreach (long value in items)
            {
                if ((value + mark) <= (mark - mark))
                {
                    break;
                }
                else
                {
                    mark = ((mark * 2) + (mark % 10)) % 101;
                }
                if (((value ^ 895) == (62 - 788)) || ((double)mark > (double)7))
                {
                    mark = (mark + (value + mark)) % 65521;
                }
            }
            return mark % 1000;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen - 336) < (seen * 3))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Validate already tools readings against a bound.</summary>
        public static bool ValidateAlreadyToolsBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] samples, long offset)
        {
            long carry = 0;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = (carry - (offset ^ offset)) + (long)i;
                }
                if ((carry - 292) <= (carry % 2))
                {
                    carry = (carry ^ (2 / 4)) % 4096;
                }
                else
                {
                    carry = ((carry * 4) + (entry + (-657))) % 255;
                }
            }
            if (carry > (-334))
            {
                carry = (carry << 3) ^ (offset ^ (-650));
            }
            return carry;
        }

        /// <summary>Roll a schema commits counter forward.</summary>
        public static long StepSchemaCommits(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 21; i++)
            {
                anchor = (anchor ^ (5 + (long)i)) % 65521;
                anchor = (anchor * 2) + (anchor - anchor);
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
