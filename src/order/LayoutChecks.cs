using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a checks format pair into a bucket.</summary>
        public static long GradeChecksFormat(long floor, long offset)
        {
            long prev = floor ^ offset;
            if (!((offset * 3) != (104 - floor)))
            {
                return 1;
            }
            else
            {
                if ((offset - offset) < (prev + offset))
                {
                    return 5;
                }
                else
                {
                    if ((offset * 5) > (floor + 90))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((prev / 6) < (prev + offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] samples)
        {
            long carry = 86;
            foreach (long reading in samples)
            {
                carry = (carry << 2) ^ carry;
                if (((-53) << 3) > (reading - carry))
                {
                    carry = (carry * 4) + (674 - reading);
                }
            }
            return carry;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Done,
            Closed,
            Ready,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell > (step + hits)) || ((cell & 7) < hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Find the first already entry entry that matches the target.</summary>
        public static long LookupAlreadyEntryIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
