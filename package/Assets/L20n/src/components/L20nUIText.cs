﻿/**
 * This source file is part of the Commercial L20n Unity Plugin.
 * 
 * Copyright (c) 2016 Glen De Cauwsemaecker (contact@glendc.com)
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *    http://www.apache.org/licenses/LICENSE-2.0

 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using UnityEngine;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif
using L20nCore.Utils;

namespace L20nUnity
{
	namespace Components
	{
		[AddComponentMenu("L20n/UIText (2D)")]
		public sealed class L20nUIText
			: Internal.L20nBaseTextComponent<Text>
		{
			public override void SetText (string text, Font font)
			{
				Component.UnwrapIf ((component) => {
					component.text = text;
					if (font != null)
						component.font = font;
				});
			}
		}
		
		#if UNITY_EDITOR
		namespace Internal
		{
			[CustomEditor (typeof (L20nUIText))]
			public class L20nUITextEditor : Internal.L20nBaseTextEditor {}
		}
		#endif
	}
}
