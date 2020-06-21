import React, { Component } from 'react';
import FiverrItem from './FiverrItem'

class LstFiverrItem extends Component {

    render() {
        return this.props.arrFiverrItem.map((fiverrItem) =>
            <FiverrItem key={fiverrItem.id} fiverrItem={fiverrItem} />
        )
    }
}

export default LstFiverrItem;
