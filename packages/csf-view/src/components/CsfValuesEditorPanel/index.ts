import { template } from './template'
import { CsfValueUnit } from '../../models'
import { FASTElement, customElement, attr, observable } from '@microsoft/fast-element'

@customElement({
  name: 'csf-values-editor-panel',
  template
})
export class CsfValuesEditorPanel extends FASTElement {
  @attr rows: string = '10'
  @attr valuePlaceholder = 'Type a Value'
  @attr extraPlaceholder = 'Empty Extra'
  @observable values: CsfValueUnit[] | string = []
}