using UnityEngine;

namespace Jammers
{
    public class DescriptionBaseSO : ScriptableObject
    {
        [TextArea(1,10)]
        public string Description;
    }
}