/// <reference path='../../_references.ts' />

module BomManager {
    'use strict';

    export class AssemblyMarkingNavigationService {
        constructor(
            private assemblyMarkingService: AssemblyMarkingService
        ) {
        }

        navigate(component: ComponentViewModel) {
            let articleLinkId = this.assemblyMarkingService.getMarkedArticleLinkId(component);

            let elementId = AssemblyMarkingNavigationService.getElementIdForFindingNodes(articleLinkId);
            
            TreeGridService.scrollTreeViewToElement(elementId);
        }

        static getElementIdForFindingNodes(articleLinkId: System.Guid) {
            return 'article-link-id-' + articleLinkId;
        }
        
    }
}