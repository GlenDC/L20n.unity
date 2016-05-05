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
using System;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace L20nUnity
{
	namespace Components
	{
		namespace Internal
		{
			/// <summary>
			/// A Material Collection, that can be used
			/// in combination with any L20nBaseResource class.
			/// </summary>
			/// <remarks>
			/// Look at the `L20nMeshRenderer` class for a use-case example.
			/// </remarks>
			[Serializable]
			public sealed class L20nMaterialCollection
			: L20nResourceCollection<Material>
			{
			}
			
			#if UNITY_EDITOR
			/// <summary>
			/// A custom drawer for this collection,
			/// inhereting away the template argument.
			/// </summary>
			[CustomPropertyDrawer(typeof(L20nMaterialCollection))]
			public sealed class L20nMaterialCollectionDrawer
			: L20nResourceCollectionDrawer
			{
			}
			#endif
		}
	}
}